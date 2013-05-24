using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMemo.model
{
    class MemoModel
    {
        private List<MemoTile> model;
        private int memoSize = 16;
        private static Random rand = new Random();
        private bool enabled;
        private int showned;

        public MemoModel()
        {
            model = new List<MemoTile>(memoSize);
            List<MemoTileType> typeList = new List<MemoTileType>(memoSize);

            for (int i = 0; i < memoSize / 2; i++)
                typeList.Add((MemoTileType)i);

            for (int i = 0; i < memoSize / 2; i++)
                typeList.Add((MemoTileType)i);
            
            
            for (int i = 0; i < memoSize; i++)
            {
                MemoTileType type = typeList[rand.Next(typeList.Count())];
                typeList.Remove(type);
                model.Add(new MemoTile(type));
            }

            showned = 0;
        }


        public bool Enabled { get { return enabled; } set { this.enabled = value; } }

        public MemoTile getMemoTile(int index)
        {
            return model[index];
        }
    }
}
