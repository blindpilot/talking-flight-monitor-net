﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfm
{
    public class ScreenReaderOutputEventArgs
    {
        public string output { get; set; }
        public string gaugeName { get; set; }
        public string gaugeValue { get; set; }
        public bool isGauge { get; set; }
        public bool useSAPI { get; set; }
        public bool textOutput { get; set; }
        public bool interruptSpeech { get; set; }
    } // end ScreenReaderOutputEventArgs
} // End TFM namespace.
