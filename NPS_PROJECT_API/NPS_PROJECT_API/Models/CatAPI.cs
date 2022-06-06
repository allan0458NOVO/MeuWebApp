namespace NPS_PROJECT_API.Models
{
    public class CatAPI
    {
        public String CatId { get; set; }

        public String CatName { get; set; }

        public CatAPI(string catId, string catName)
        {
            CatId = catId;
            CatName = catName;
        }

        public CatAPI()
        {
        }
    }
}
