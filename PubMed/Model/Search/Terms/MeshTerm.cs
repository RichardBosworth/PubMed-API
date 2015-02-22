namespace PubMed.Model.Search.Terms
{
    public class MeshTerm : SearchTerm
    {


        public MeshTerm(string term) : base(term)
        {
        }

        protected override string SearchTagString
        {
            get { return "MESH Terms"; }
        }
    }
}