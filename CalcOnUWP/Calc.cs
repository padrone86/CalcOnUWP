using Prism.Mvvm;

namespace CalcOnUWP
{
    public class Calc : BindableBase
    {
        private int _num1;
        private int _num2;

        /// <summary>
        /// 足される数
        /// </summary>
        public int num1
        {
            get { return _num1; }
            set
            {
                SetProperty(ref _num1, value);
                RaisePropertyChanged(nameof(sum));
            }
        }

        /// <summary>
        /// 足す数
        /// </summary>
        public int num2
        {
            get { return _num2; }
            set
            {
                SetProperty(ref _num2, value);
                RaisePropertyChanged(nameof(sum));
            }
        }

        /// <summary>
        /// 合計
        /// </summary>
        public int sum { get { return num1 + num2; } }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Calc()
        {
            num1 = 0;
            num2 = 0;
        }
    }
}
