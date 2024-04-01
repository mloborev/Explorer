using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Models
{
    public class DirectoriesAndFilesModel
    {
        public List<Directory> Directories { get; set; }
        public List<File> Files { get; set; }
        public List<Element> Elements { get; set; }

    }

    public class Element
    {
        public string Path { get; set; }
        public string Type { get; set; }
    }
    public class File : Element
    {
        
    }
    public class Directory : Element
    {

    }
}
