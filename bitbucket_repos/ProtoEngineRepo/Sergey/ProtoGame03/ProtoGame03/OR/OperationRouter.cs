using ProtoGame03.Adapters;
using ProtoGame03.IM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProtoGame03.OR
{
    class OperationRouter
    {
        InstanceManager im = new InstanceManager();

        public IList<IModelAdapter> ModelAdapters { get; private set; }

        internal IModelAdapter LoadBoard(uint boardId)
        {
            ModelAdapters = new List<IModelAdapter>();
            IInstance board = im.Read(boardId);
            IModelAdapter temp = CreateAdapter(board);

            CollectAllRelated(temp, board);
            return temp;
        }

        private void CollectAllRelated(IModelAdapter x, IInstance root)
        {
            foreach (uint related in root.RelatedInstances)
            {
                x.RelatedInstances.Add(CreateAdapter(im.Read(related)));
            }
        }

        private IModelAdapter CreateAdapter(IInstance x)
        {
            IModelAdapter temp = new ModelAdapter(x.Tid, x.Id, GetParent(x.Parent));
            ModelAdapters.Add(temp);
            return temp;
        }

        private IModelAdapter GetParent(uint parent)
        {
            return ModelAdapters.Where(x => x.Id == parent).FirstOrDefault();
        }
    }
}
