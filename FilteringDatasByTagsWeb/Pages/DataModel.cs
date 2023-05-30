using System.ComponentModel.DataAnnotations;

namespace FilteringDatasByTagsWeb.Pages
{
    public class DataModel
    {
        [Required(ErrorMessage = "入力必須じゃボケ！")]
        public string BeforeData { get; set; }
        public string AfterData { get; set; }
    }
}
