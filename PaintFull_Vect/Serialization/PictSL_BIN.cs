using PaintFull_Vect.API;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PaintFull_Vect.Serialization
{
    public class PictSL_BIN: IPictSL
    {
        string path = "";
        public PictSL_BIN(string path)
        {
            this.path = path;
        }


        public List<PFigure> Load()
        {
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Close();
                return new List<PFigure>();
            }
            List<FigureMemento> lf = new List<FigureMemento>();
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                lf = (List<FigureMemento>)bformatter.Deserialize(stream);
            }
            return FigureSerializer.GetFiguresList(lf);
        }

        public void Save(List<PFigure> figures)
        {
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, FigureSerializer.GetMementoList(figures));
            }
        }
    }
}
