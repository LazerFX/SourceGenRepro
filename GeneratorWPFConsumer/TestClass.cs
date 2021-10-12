using AutoNotify;

namespace GeneratorWPFConsumer
{
    public partial class TestClass
    {
        public TestClass(decimal Open, decimal Close, decimal High, decimal Low, string TestString)
        {
            this._open = Open;
            this._close = Close;
            this._high = High;
            this._low = Low;
            this._testString = TestString;
        }

        [AutoNotify]
        private decimal _open;
        [AutoNotify]
        private decimal _close;
        [AutoNotify]
        private decimal _high;
        [AutoNotify]
        private decimal _low;
        [AutoNotify]
        private string _testString;
    }
}
