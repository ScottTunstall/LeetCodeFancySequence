using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeFancySequence
{


    public class Fancy
    {
        private const int MODULO = 1000000007;

        private enum OpType
        {
            Add,
            Multiply
        }

        private struct Op
        {
            public OpType OpType;
            public int Val;
            public int AppliesUpToIndex;
        }


        private List<int> _vals;
        private List<Op> _ops;

        public Fancy()
        {
            _vals = new();
            _ops = new();
        }

        public void Append(int val)
        {
            _vals.Add(val);
        }

        public void AddAll(int inc)
        {
            _ops.Add(new Op()
            {
                OpType = OpType.Add,
                Val = inc,
                AppliesUpToIndex = _vals.Count-1
            });
        }

        public void MultAll(int m)
        {
            _ops.Add(new Op()
            {
                OpType = OpType.Multiply,
                Val = m,
                AppliesUpToIndex = _vals.Count - 1
            });
        }

        public int GetIndex(int idx)
        {
            if (idx >= _vals.Count)
                return -1;

            return GetValue(idx);
        }

        private int GetValue(int idx)
        {
            var val = _vals[idx];

            BigInteger asBig = new(val);

            foreach (var op in _ops.Where(x=>x.AppliesUpToIndex >=idx))
            {
                switch (op.OpType)
                {
                    case OpType.Add:
                        asBig += op.Val;
                        break;

                    case OpType.Multiply:
                        asBig *= op.Val;
                        break;

                }
            }

            return (int) (asBig % MODULO);
        }
    }
}
