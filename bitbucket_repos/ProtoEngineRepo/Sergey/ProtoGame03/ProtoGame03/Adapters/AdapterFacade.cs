using ProtoGame03.OR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoGame03.Adapters
{
    public class AdapterFacade
    {
        OperationRouter or;
        public IList<IModelAdapter> modelAdapters => or.ModelAdapters;
        public void Load(uint boardId)
        {
            or = new OperationRouter();
            or.LoadBoard(boardId);
        }
    }
}
