using PaintFull_Vect.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintFull_Vect.Serialization
{
    public class FigureSerializer
    {
        public static List<FigureMemento> GetMementoList(List<PFigure> figures)
        {
            List<FigureMemento> fm = new List<FigureMemento>();
            foreach (PFigure f in figures)
            {
                fm.Add(f.GetMemento());
            }
            return fm;
        }
        public static List<PFigure> GetFiguresList(List<FigureMemento> fm)
        {
            List<PFigure> figures = new List<PFigure>();
            foreach (FigureMemento f in fm)
            {
                PFigure figure = new PFigure();
                figure.SetMemento(f);
                figures.Add(figure);
            }
            return figures;
        }
    }
}
