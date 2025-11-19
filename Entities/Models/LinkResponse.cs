using Entities.LinkModels;
using System.Dynamic;

namespace Entities.Models
{
    public class LinkResponse
    {
        public bool HasLinks { get; set; }

        public List<ExpandoObject> ShapedEntities { get; set; }

        public LinksCollectionWrapper<ExpandoObject> LinkedEntities { get; set; }

        public LinkResponse()
        {
            LinkedEntities = new LinksCollectionWrapper<ExpandoObject>();
            ShapedEntities = new List<ExpandoObject> ();
        }
    }
}