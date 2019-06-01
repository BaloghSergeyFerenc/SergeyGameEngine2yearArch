using PersistenceTopLayer.ModelProvier;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceTopLayer.Fakes
{
    class ProtoModel2Fake
    {
        IDictionary<uint, IModelObject> Instances;
        public IDictionary<uint, IModelObject> InitModel()
        {
            Instances = new Dictionary<uint, IModelObject>();

            CreateBoard();
            CreateFields();
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
            board.Properties.Add(2001, "4");//Size/number of fields
            board.Properties.Add(2002, "2");//X-Range
            board.Properties.Add(2003, "2");//Y-Range

            board.Actions.Add(3001);//Delete
            board.Actions.Add(3005);//CreateFigure

            Instances.Add(1001, board);
        }

        private void CreateFields()
        {
            for (uint i = 1; i < 5; i++)
            {
                IModelObject field = new ModelObject()
                {
                    Tid = 2,
                    Id = 1001 + i,
                    Parent = 1001
                };
                field.Properties.Add(2004, GetXcoordinate(i));//X-koordinate
                field.Properties.Add(2005, GetYcoordinate(i));//Y-koordinate
                field.Properties.Add(2006, (i == 1).ToString());//HasFigure
                field.Properties.Add(2007, "Yellow");//Color

                field.Actions.Add(3001);//Delete

                Instances[field.Parent].Children.Add(field.Id);
                Instances.Add(1001 + i, field);
            }
        }

        private void CreateFigure()
        {
            IModelObject figure = new ModelObject()
            {
                Tid = 3,
                Id = 1006,
                Parent = 1002
            };
            figure.Properties.Add(2007, "Green");//Color

            figure.Actions.Add(3001);//Delete
            figure.Actions.Add(3002);//ChangeColor
            figure.Actions.Add(3003);
            figure.Actions.Add(3004);

            Instances[figure.Parent].Children.Add(figure.Id);
            Instances.Add(1006, figure);
        }

        private string GetXcoordinate(uint i)
        {
            switch (i)
            {
                case 1:
                case 3:
                    return (1).ToString();
                case 2:
                case 4:
                    return (2).ToString();
                default:
                    return (0).ToString();
            }
        }

        private string GetYcoordinate(uint i)
        {
            switch (i)
            {
                case 1:
                case 2:
                    return (1).ToString();
                case 3:
                case 4:
                    return (2).ToString();
                default:
                    return (0).ToString();
            }
        }
    }
}
