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
        }

        private class PreCalculatedValue
        {
            public BigInteger Value;
            public int OpIndex;
        }

        private readonly List<int> _vals;
        private readonly List<Op> _ops;
        private readonly Dictionary<int, PreCalculatedValue> _calculatedValues;

        public Fancy()
        {
            _vals = new List<int>();
            _ops = new List<Op>();
            _calculatedValues = new Dictionary<int, PreCalculatedValue>();
        }

        public void Append(int val)
        {
            _vals.Add(val);
            SetPreCalculatedValue(_vals.Count-1, _ops.Count, val);
        }

        public void AddAll(int inc)
        {
            _ops.Add(new Op()
            {
                OpType = OpType.Add,
                Val = inc,
            });
        }

        public void MultAll(int m)
        {
            _ops.Add(new Op()
            {
                OpType = OpType.Multiply,
                Val = m,
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
            var calc = GetPreCalculatedValue(idx);
            var asBig = calc.Value;

            for (int i=calc.OpIndex; i<_ops.Count; i++)
            {
                var op = _ops[i];
                if (op.OpType == OpType.Add)
                    asBig += op.Val;
                else
                    asBig *= op.Val;
                
            }

            //var val = (int) asBig;

            SetPreCalculatedValue(idx, _ops.Count, asBig);

            return (int) (asBig % MODULO);
        }



        private PreCalculatedValue GetPreCalculatedValue(int idx)
        { 
            return _calculatedValues[idx];
        }


        private void SetPreCalculatedValue(int idx, int opIndex, in BigInteger value)
        {
            if (!_calculatedValues.ContainsKey(idx))
                _calculatedValues[idx] = new PreCalculatedValue();
            
            _calculatedValues[idx].OpIndex = opIndex;
            _calculatedValues[idx].Value = value;

        }
    }
}
