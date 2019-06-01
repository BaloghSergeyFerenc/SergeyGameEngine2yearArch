using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame04.InstanceManager.ModelInitializer
{
    class ProtoModel1
    {
        IDictionary<uint, IInstance> Instances;
        public IDictionary<uint, IInstance> InitModel()
        {
            Instances = new Dictionary<uint, IInstance>();

            CreateBoard();
            CreateField();
            CreateFigure();

            return Instances;
        }

        private void CreateBoard()
        {
            IInstance board = new Instance()
            {
                Tid = 1,
                Id = 1001,
                Parent = 0
            };
            board.Properties.Add(2001, "1");//Size/number of fields
            board.Properties.Add(2002, "1");//X-Range
            board.Properties.Add(2003, "1");//Y-Range

            board.Functions.Add(3001);//Delete

            Instances.Add(1001, board);
        }

        private void CreateField()
        {
            IInstance field = new Instance()
            {
                Tid = 2,
                Id = 1002,
                Parent = 1001
            };
            field.Properties.Add(2004, "1");//X-koordinate
            field.Properties.Add(2005, "1");//Y-koordinate
            field.Properties.Add(2006, "true");//HasFigure

            field.Functions.Add(3001);//Delete

            Instances[field.Parent].Children.Add(field.Id);
            Instances.Add(1002, field);
        }

        private void CreateFigure()
        {
            IInstance figure = new Instance()
            {
                Tid = 3,
                Id = 1003,
                Parent = 1002
            };
            figure.Properties.Add(2007, "Green");//Color

            figure.Functions.Add(3001);//Delete
            figure.Functions.Add(3002);//ChangeColor

            Instances[figure.Parent].Children.Add(figure.Id);
            Instances.Add(1003, figure);
        }
    }
}
