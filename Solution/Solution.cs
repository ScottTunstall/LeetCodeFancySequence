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

        private class Op
        {
            public OpType OpType;
            public int Val;
            public int AppliesUpToIndex;
        }

        private class CalculatedValue
        {
            public BigInteger Value;
            public int OpIndex;
        }

        private List<int> _vals;
        private List<Op> _ops;
        private Dictionary<int, CalculatedValue> _calculatedValues;

        public Fancy()
        {
            _vals = new List<int>();
            _ops = new List<Op>();
            _calculatedValues = new Dictionary<int, CalculatedValue>();
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
            var calc = GetCalculatedValue(idx);
            var asBig = calc.Value;

            for (int i=calc.OpIndex; i<_ops.Count; i++)
            {
                var op = _ops[i];

                if (idx > op.AppliesUpToIndex)
                    continue;

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

            //var val = (int) asBig;

            SetCalculatedValue(idx, _ops.Count, asBig);

            return (int) (asBig % MODULO);
        }



        private CalculatedValue GetCalculatedValue(int idx)
        {
            if (_calculatedValues.ContainsKey(idx))
            {
                return _calculatedValues[idx];
            }

            return new CalculatedValue()
            {
                OpIndex = 0,
                Value = _vals[idx]
            };
        }


        private void SetCalculatedValue(int idx, int opIndex, BigInteger value)
        {
            if (!_calculatedValues.ContainsKey(idx))
                _calculatedValues[idx] = new CalculatedValue();
            
            _calculatedValues[idx].OpIndex = opIndex;
            _calculatedValues[idx].Value = value;

        }
    }
}
