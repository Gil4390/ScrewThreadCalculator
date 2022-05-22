using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Calculator.ViewModel
{
    class ISO_Metric_VM : NotifiableObject
    {
        private List<string> sPlist = new List<string>(0);
        public List<string> SPlist
        {
            get => sPlist;
            set { sPlist = value; }
        }

        private string comboBoxText;
        public string ComboBoxText
        {
            get => comboBoxText;
            set { comboBoxText = value; RaisePropertyChanged("ComboBoxText"); }
        }

        private string exd1max = "---";
        public string Exd1max
        {
            get => exd1max;
            set { exd1max = value; RaisePropertyChanged("Exd1max"); }
        }

        private string exd1min = "---";
        public string Exd1min
        {
            get => exd1min;
            set { exd1min = value; RaisePropertyChanged("Exd1min"); }
        }

        private string exd2max = "---";
        public string Exd2max
        {
            get => exd2max;
            set { exd2max = value; RaisePropertyChanged("Exd2max"); }
        }

        private string exd2min = "---";
        public string Exd2min
        {
            get => exd2min;
            set { exd2min = value; RaisePropertyChanged("Exd2min"); }
        }

        private string exd3max = "---";
        public string Exd3max
        {
            get => exd3max;
            set { exd3max = value; RaisePropertyChanged("Exd3max"); }
        }

        private string exd3min = "---";
        public string Exd3min
        {
            get => exd3min;
            set { exd3min = value; RaisePropertyChanged("Exd3min"); }
        }

        //==========

        private string ind1max = "---";
        public string Ind1max
        {
            get => ind1max;
            set { ind1max = value; RaisePropertyChanged("Ind1max"); }
        }
        private string ind1min = "---";
        public string Ind1min
        {
            get => ind1min;
            set { ind1min = value; RaisePropertyChanged("Ind1min"); }
        }

        private string ind2max = "---";
        public string Ind2max
        {
            get => ind2max;
            set { ind2max = value; RaisePropertyChanged("Ind2max"); }
        }

        private string ind2min = "---";
        public string Ind2min
        {
            get => ind2min;
            set { ind2min = value; RaisePropertyChanged("Ind2min"); }
        }

        private string ind3max = "---";
        public string Ind3max
        {
            get => ind3max;
            set { ind3max = value; RaisePropertyChanged("Ind3max"); }
        }

        private string ind3min = "---";
        public string Ind3min
        {
            get => ind3min;
            set { ind3min = value; RaisePropertyChanged("Ind3min"); }
        }

        public string size = "";
        public string Size
        {
            get => size;
            set { size = value; RaisePropertyChanged("Size"); }
        }

        public string pitch = "";
        public string Pitch
        {
            get => pitch;
            set { pitch = value; RaisePropertyChanged("Pitch"); }
        }

        public string errorText = "";
        public string ErrorText
        {
            get => errorText;
            set { errorText = value; RaisePropertyChanged("ErrorText"); }
        }

        Excel excel;
        Dictionary<string, int> values;
        Dictionary<double, List<double>> pitches_sizes;

        public ISO_Metric_VM()
        {
            sPlist.Add("");
            string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "db.xlsx"));
            excel = new Excel(path, 1);
            int index = 4;
            bool b = true;

            values = new Dictionary<string, int>();
            pitches_sizes = new Dictionary<double, List<double>>();
            while (b)
            {
                string val = excel.ReadCell(index, 1);
                if (val != "")
                {
                    values[val] = index;
                    sPlist.Add(val);

                    //for custom
                    string[] split = val.Split(" x ");
                    string val_pitch = split[1];
                    string val_size = split[0].Substring(2);
                    double val_p = Convert.ToDouble(val_pitch);
                    double val_s = Convert.ToDouble(val_size);
                    if (!pitches_sizes.ContainsKey(val_p)) pitches_sizes[val_p] = new List<double>();
                    //add sorting if necessary
                    pitches_sizes[val_p].Add(val_s);
                }
                else
                {
                    b = false;
                }
                index++;
            }
        }

        public void Show()
        {
            if (comboBoxText != "")
            {
                int row = values[comboBoxText];
                Exd1max = excel.ReadCell(row, 2);
                Exd1min = excel.ReadCell(row, 3);
                Exd2max = excel.ReadCell(row, 4);
                Exd2min = excel.ReadCell(row, 5);
                Exd3max = excel.ReadCell(row, 6);
                Exd3min = excel.ReadCell(row, 7);
                Ind1max = excel.ReadCell(row, 8);
                Ind1min = excel.ReadCell(row, 9);
                Ind2max = excel.ReadCell(row, 10);
                Ind2min = excel.ReadCell(row, 11);
                Ind3max = excel.ReadCell(row, 12);
                Ind3min = excel.ReadCell(row, 13);
            }
            else
            {
                try
                {
                    double val_p = Convert.ToDouble(Pitch);
                    double val_s = Convert.ToDouble(Size);
                    if (!pitches_sizes.ContainsKey(val_p)) ErrorText = "Invalid Pitch";
                    else
                    {
                        ErrorText = "";
                        List<double> sizes = pitches_sizes[val_p];
                        double best_size = sizes[0];
                        double diff = val_s - best_size;
                        bool neg = diff < 0;
                        diff = Math.Abs(diff);
                        foreach(double s in sizes)
                        {
                            if (Math.Abs(s - val_s) < diff)
                            {
                                diff = val_s - s;
                                neg = diff < 0;
                                diff = Math.Abs(diff);
                                best_size = s;
                            }
                        }

                        if (neg) diff *= -1;

                        string key = "M " + best_size.ToString() + " x " + val_p.ToString();
                        int row = values[key];
                        Exd1max = (Convert.ToDouble(excel.ReadCell(row, 2)) + diff).ToString("#0.000");
                        Exd1min = (Convert.ToDouble(excel.ReadCell(row, 3)) + diff).ToString("#0.000");
                        Exd2max = (Convert.ToDouble(excel.ReadCell(row, 4)) + diff).ToString("#0.000");
                        Exd2min = (Convert.ToDouble(excel.ReadCell(row, 5)) + diff).ToString("#0.000");
                        Exd3max = (Convert.ToDouble(excel.ReadCell(row, 6)) + diff).ToString("#0.000");
                        Exd3min = (Convert.ToDouble(excel.ReadCell(row, 7)) + diff).ToString("#0.000");
                        Ind1max = (Convert.ToDouble(excel.ReadCell(row, 8)) + diff).ToString("#0.000");
                        Ind1min = (Convert.ToDouble(excel.ReadCell(row, 9)) + diff).ToString("#0.000");
                        Ind2max = (Convert.ToDouble(excel.ReadCell(row, 10)) + diff).ToString("#0.000");
                        Ind2min = (Convert.ToDouble(excel.ReadCell(row, 11)) + diff).ToString("#0.000");
                        Ind3max = (Convert.ToDouble(excel.ReadCell(row, 12)) + diff).ToString("#0.000");
                        Ind3min = (Convert.ToDouble(excel.ReadCell(row, 13)) + diff).ToString("#0.000");
                    }
                }
                catch (FormatException e)
                {
                    ErrorText = "Invalid Input";
                }
                catch (Exception e)
                {
                    ErrorText = e.ToString();
                }

            }
        }

        internal void Close()
        {
            excel.Close();
        }
    }
}
