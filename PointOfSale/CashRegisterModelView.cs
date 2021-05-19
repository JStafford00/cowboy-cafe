using CashRegister;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// The ModelView for a cash register control
    /// </summary>
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that notifies when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Model class for this ModelView
        /// </summary> 
        private static CashDrawer drawer = new CashDrawer();

        private double amountNeeded = 0.0;

        /// <summary>
        /// Currency Needed
        /// </summary>
        private int penniesNeeded = 0;
        private int nicklesNeeded = 0;
        private int dimesNeeded = 0;
        private int quartersNeeded = 0;
        private int onesNeeded = 0;
        private int fivesNeeded = 0;
        private int tensNeeded = 0;
        private int twentiesNeeded = 0;
        private int fiftiesNeeded = 0;
        private int hundredsNeeded = 0;

        /// <summary>
        /// Getter/Setter for amountNeeded
        /// </summary>
        public double AmountNeeded
        {
            get
            {
                return amountNeeded;
            }
            set
            {
                amountNeeded = value;
                CalculateBillsNeeded(amountNeeded);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountNeeded"));
            }
        }

        /// <summary>
        /// Getter for penniesNeeded
        /// </summary>
        public int PenniesNeeded
        {
            get
            {
                return penniesNeeded;
            }
        }

        /// <summary>
        /// Getter for nicklesNeeded
        /// </summary>
        public int NicklesNeeded
        {
            get
            {
                return nicklesNeeded;
            }
        }

        /// <summary>
        /// Getter for dimesNeeded
        /// </summary>
        public int DimesNeeded
        {
            get
            {
                return dimesNeeded;
            }
        }

        /// <summary>
        /// Getter for quartersNeeded
        /// </summary>
        public int QuartersNeeded
        {
            get
            {
                return quartersNeeded;
            }
        }

        /// <summary>
        /// Getter for onessNeeded
        /// </summary>
        public int OnesNeeded
        {
            get
            {
                return onesNeeded;
            }
        }

        /// <summary>
        /// Getter for fivesNeeded
        /// </summary>
        public int FivesNeeded
        {
            get
            {
                return fivesNeeded;
            }
        }

        /// <summary>
        /// Getter for tensNeeded
        /// </summary>
        public int TensNeeded
        {
            get
            {
                return tensNeeded;
            }
        }

        /// <summary>
        /// Getter for twentiesNeeded
        /// </summary>
        public int TwentiesNeeded
        {
            get
            {
                return twentiesNeeded;
            }
        }

        /// <summary>
        /// Getter for fiftiesNeeded
        /// </summary>
        public int FiftiesNeeded
        {
            get
            {
                return fiftiesNeeded;
            }
        }

        /// <summary>
        /// Getter for hundredsNeeded
        /// </summary>
        public int HundredsNeeded
        {
            get
            {
                return hundredsNeeded;
            }
        }

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountNeeded"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        private void CalculateBillsNeeded(double data)
        {

            if (data >= 100)
            {
                hundredsNeeded++;
                data -= 100;
                CalculateBillsNeeded(data);
            }

            else if (data >= 50)
            {
                fiftiesNeeded++;
                data -= 50;
                CalculateBillsNeeded(data);
            }

            else if (data >= 20)
            {
                twentiesNeeded++;
                data -= 20;
                CalculateBillsNeeded(data);
            }

            else if (data >= 10)
            {
                tensNeeded++;
                data -= 10;
                CalculateBillsNeeded(data);
            }

            else if (data >= 5)
            {
                fivesNeeded++;
                data -= 10;
                CalculateBillsNeeded(data);
            }

            else if (data >= 1)
            {
                onesNeeded++;
                data--;
                CalculateBillsNeeded(data);
            }

            else if (data >= 0.25)
            {
                quartersNeeded++;
                data -= 0.25;
                CalculateBillsNeeded(data);
            }

            else if (data >= 0.1)
            {
                dimesNeeded++;
                data -= 0.1;
                CalculateBillsNeeded(data);
            }

            else if (data >= 0.05)
            {
                nicklesNeeded++;
                data -= 0.05;
                CalculateBillsNeeded(data);
            }

            else if (data >= 0.005)
            {
                penniesNeeded++;
                data -= 0.01;
                CalculateBillsNeeded(data);
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BillsNeeded"));
        }

        private void ZeroOut()
        {
            penniesNeeded = 0;
            nicklesNeeded = 0;
            dimesNeeded = 0;
            quartersNeeded = 0;
            onesNeeded = 0;
            fivesNeeded = 0;
            tensNeeded = 0;
            twentiesNeeded = 0;
            fiftiesNeeded = 0;
            hundredsNeeded = 0;
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0)
                    return;
                int quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    amountNeeded -= 0.01;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    amountNeeded += 0.01;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets or sets the number of dimes in the cash register
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0)
                    return;
                int quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                    amountNeeded -= 0.1;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    amountNeeded += 0.1;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets or sets the number of nickels in the cash register
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0)
                    return;
                int quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    amountNeeded -= 0.05;
                }

                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    amountNeeded += 0.05;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets or sets the number of quarters in the cash register
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0)
                    return;
                int quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantity);
                    amountNeeded -= 0.25;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                    amountNeeded += 0.25;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Gets or sets the number of half dollar in the cash register
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0)
                    return;
                int quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                    amountNeeded -= 0.5;
                }
                else
                {
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                    amountNeeded += 0.5;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// Gets or sets the number of dollars in the cash register
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0)
                    return;
                int quantity = value - drawer.Dollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dollar, quantity);
                    amountNeeded--;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                    amountNeeded++;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// Gets or sets the number of ones in the cash register
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0)
                    return;
                int quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.One, quantity);
                    amountNeeded--;
                }
                else
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    amountNeeded++;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Gets or sets the number of fives in the cash register
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0)
                    return;
                int quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                    amountNeeded -= 5;
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    amountNeeded += 5;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Gets or sets the number of tens in the cash register
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0)
                    return;
                int quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Ten, quantity);
                    amountNeeded -= 10;
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    amountNeeded += 10;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Gets or sets the number of twenties in the cash register
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0)
                    return;
                int quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                    amountNeeded -= 20;
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    amountNeeded += 20;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Gets or sets the number of fifties in the cash register
        /// </summary>
        public int Fifties
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0)
                    return;
                int quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                    amountNeeded -= 50;
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                    amountNeeded += 50;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Gets or sets the number of hundreds in the cash register
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0)
                    return;
                int quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                    amountNeeded -= 100;
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    amountNeeded += 100;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Gets or sets the number of twos in the cash register
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0)
                    return;
                int quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Two, quantity);
                    amountNeeded -= 2;
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    amountNeeded += 2;
                }
                ZeroOut();
                CalculateBillsNeeded(amountNeeded);
                InvokePropertyChanged("Twos");
            }
        }
    }
}
