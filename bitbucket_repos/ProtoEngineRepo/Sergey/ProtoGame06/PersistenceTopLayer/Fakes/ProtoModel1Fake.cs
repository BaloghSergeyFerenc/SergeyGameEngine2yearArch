using PersistenceTopLayer.ModelProvier;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.Fakes
{
    class ProtoModel1Fake
    {
        IDictionary<uint, IModelObject> Instances;
        public IDictionary<uint, IModelObject> InitModel()
        {
            Instances = new Dictionary<uint, IModelObject>();

            CreateBoard();
            CreateField();
            CreateFigure();

            return Instances;
        }

        private void CreateBoard()
        {
            IModelObject board = new ModelObject()
            {
                Tid = 1,
                Id = 1001,
                Parent = 0
            };
            board.Properties.Add(2001, "1");//Size/number of fields
            board.Properties.Add(2002, "1");//X-Range
            board.Properties.Add(2003, "1");//Y-Range

            board.Actions.Add(3001);//Delete

            Instances.Add(1001, board);
        }

        private void CreateField()
        {
            IModelObject field = new ModelObject()
            {
                Tid = 2,
                Id = 1002,
                Parent = 1001
            };
            field.Properties.Add(2004, "1");//X-koordinate
            field.Properties.Add(2005, "1");//Y-koordinate
            field.Properties.Add(2006, "true");//HasFigure

            field.Actions.Add(3001);//Delete

            Instances[field.Parent].Children.Add(field.Id);
            Instances.Add(1002, field);
        }

        private void CreateFigure()
        {
            IModelObject figure = new ModelObject()
            {
                Tid = 3,
                Id = 1003,
                Parent = 1002
            };
            figure.Properties.Add(2007, "Green");//Color

            figure.Actions.Add(3001);//Delete
            figure.Actions.Add(3002);//ChangeColor

            Instances[figure.Parent].Children.Add(figure.Id);
            Instances.Add(1003, figure);
        }
    }
}
