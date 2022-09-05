using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BookCategory
    {
        private int _catid;

        public int BookCatId
        {
            get { return _catid; }
            set { _catid = value; }
        }
        private string _catname;

        public string BookCatName
        {
            get { return _catname; }
            set { _catname = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public BookCategory()
        {

        }
        public BookCategory(int cid)
        {
            _catid = cid;
        }
    }
}
