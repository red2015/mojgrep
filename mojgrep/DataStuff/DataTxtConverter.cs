namespace mojgrep.DataStuff
{
    public class DataTxtConverter : IDataConverter
    {
        private string[] _data;
        public DataTxtConverter(string[] data)
        {
            _data = data;
        }

        public string[] GetData()
        {
            return _data;
        }
    }
}