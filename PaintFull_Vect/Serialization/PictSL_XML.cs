using PaintFull_Vect.API;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PaintFull_Vect.Serialization
{
    public class PictSL_XML : IPictSL
    {
        string path = "";
        public PictSL_XML(string path)
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
            TextReader reader = File.OpenText(path);

            XmlSerializer serializer = new XmlSerializer(typeof(List<FigureMemento>));
            List<FigureMemento> figures = new List<FigureMemento>();
            try
            {
                figures = (List<FigureMemento>)serializer.Deserialize(reader);
            }
            catch (Exception exception)
            {
                figures = new List<FigureMemento>();
            }

            reader.Close();
            return FigureSerializer.GetFiguresList(figures);
        }

        public void Save(List<PFigure> figures)
        {
            TextWriter writer = File.CreateText(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<FigureMemento>));
            serializer.Serialize(writer, FigureSerializer.GetMementoList(figures));
            writer.Close();
        }
    }
}
