﻿#if WORKINPROGRESS

namespace System.ComponentModel
{
    public abstract class GroupDescription : INotifyPropertyChanged
    {
        protected event PropertyChangedEventHandler PropertyChanged;

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
    }
}

#endif