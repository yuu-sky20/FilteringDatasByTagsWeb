namespace FilteringDatasByTagsWeb.Pages
{
    public class FilteringDatasByTags
    {
        public string Convert(string srcText)
        {

            Dictionary<string, List<List<string>>> mapDatas = new Dictionary<string, List<List<string>>>();

            string[] allText = srcText.Split('\n');
            foreach (string line in allText)
            {
                string[] contexts = line.Split("\t");
                string key = contexts[0];
                string[] values = contexts.Skip(1).ToArray();
                if (mapDatas.ContainsKey(key))
                {
                    List<List<string>> listDatas = mapDatas[key];
                    listDatas.Add(values.ToList());
                    mapDatas[key] = listDatas;
                }
                else
                {
                    List<List<string>> listDatas = new List<List<string>> { values.ToList() };
                    mapDatas.Add(key, listDatas);

                }
            }
            string dstText = "";

            foreach (var data in mapDatas)
            {
                foreach (var item in data.Value)
                {
                    string v = string.Join("\t", item);
                    string line = $"{data.Key}\t{v}\n";
                    dstText += line;
                }
                dstText += "\n";
            }
            return dstText;
        }
    }
}
