using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintFull_Vect.Serialization
{
    public class SLFactory
    {
        public static IPictSL GetInstance(string type)
        {
            IPictSL ps = null;
            string[] str = type.Split('.');
            switch (str[str.Length - 1])
            {
                case "bin":
                    ps = new PictSL_BIN(type);
                    break;
                case "json":
                    ps = new PictSL_JSON(type);
                    break;
                case "xml":
                    ps = new PictSL_XML(type);
                    break;
                case "yaml":
                    ps = new PictSL_YAML(type);
                    break;
            }
            return ps;
        }
    }
}
