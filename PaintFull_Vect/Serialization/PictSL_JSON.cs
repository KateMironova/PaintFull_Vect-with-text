using PaintFull_Vect.API;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PaintFull_Vect.Serialization
{
    public class PictSL_JSON : IPictSL
    {
        string path = "";
        public PictSL_JSON(string path)
        {
            this.path = path;
        }


        public List<PFigure> Load()
        {
            if (File.Exists(path) == false)
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            string jsonString = File.ReadAllText(path);
            List<FigureMemento> figures = new List<FigureMemento>();
            if (jsonString.Length != 0)
                figures = JsonConvert.DeserializeObject<List<FigureMemento>>(jsonString);

            return FigureSerializer.GetFiguresList(figures);
        }

        public void Save(List<PFigure> figures)
        {
            string jsonString = JsonConvert.SerializeObject(FigureSerializer.GetMementoList(figures));
            File.WriteAllText(path, jsonString);
        }
    }
}
