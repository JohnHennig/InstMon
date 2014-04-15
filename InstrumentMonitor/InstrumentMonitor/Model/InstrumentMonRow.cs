using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveUI;

namespace InstrumentMonitor
{
    /// <summary>
    /// InstrumentMonRow is a reactive object that allows for threadsafe notification to the GUI of underlying model changes
    /// </summary>
    public class InstrumentMonRow : ReactiveObject
    {
        #region Private Members

        private Instrument _instrument;

       #pragma warning disable 0649 // Assigned by reflection
        private double _Bid;
        private double _Ask;
        private double _Price;
        private string _PriceSource;
        private bool _IsSubscribed;
       #pragma warning restore 0649

        #endregion

        #region Public Members
        public int InstrumentID { get { return _instrument.InstrumentID; } }
        public string Name { get { return _instrument.InstrumentName; } }

        public bool IsSubscribed
        {
            get
            {
                return _IsSubscribed;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.IsSubscribed, value);
            }
        }

        public double Bid
        {
            get
            {
                return _Bid;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.Bid, value);
            }
        }

        public double Ask
        {
            get
            {
                return _Ask;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.Ask, value);
            }
        }

        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.Price, value);
            }
        }

        public string PriceSource
        {
            get
            {
                return _PriceSource;
            }
            set
            {
                this.RaiseAndSetIfChanged(x => x.PriceSource, value);
            }
        }
        #endregion

        #region Constructors

        public InstrumentMonRow(Instrument instrument)
        {
            _instrument = instrument;
        }

        #endregion

    }
}
