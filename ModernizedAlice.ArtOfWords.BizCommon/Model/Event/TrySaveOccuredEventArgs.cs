﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernizedAlice.ArtOfWords.BizCommon.Model.Event
{
    public class TrySaveOccuredEventArgs : EventArgs
    {
        public SaveKind SaveKind;
    }
}
