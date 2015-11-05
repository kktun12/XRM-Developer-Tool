﻿using System.Collections.Generic;
using System.Linq;
using JosephM.Application.ViewModel.RecordEntry.Form;
using JosephM.Core.FieldType;

namespace JosephM.Application.ViewModel.RecordEntry.Field
{
    public abstract class DropdownFieldViewModel<T>
        : FieldViewModel<T>
        where T : PicklistOption
    {
        protected DropdownFieldViewModel(string fieldName, string label, RecordEntryViewModelBase recordForm)
            : base(fieldName, label, recordForm)
        {
        }

        private IEnumerable<T> _itemsSource;

        public IEnumerable<T> ItemsSource
        {
            get { return _itemsSource; }
            set
            {
                _itemsSource = value;
                OnPropertyChanged("ItemsSource");
                if (Value != null && _itemsSource != null)
                {
                    var matchingItems = _itemsSource.Where(p => p.Key == Value.Key);
                    if (matchingItems.Any())
                        Value.Value = matchingItems.First().Value ?? Value.Value;
                }
            }
        }
    }
}