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
        }

        private class PreCalculatedValue
        {
            public int Value;
            public int OpIndex;
        }

        private List<int>_vals;
        private int _currval;
        private readonly List<Op> _ops;
        private readonly Dictionary<int, PreCalculatedValue> _calculatedValues;

        public Fancy()
        {
            _vals = new List<int>();
            _currval = 0;
            _ops = new List<Op>();
            _calculatedValues = new Dictionary<int, PreCalculatedValue>();
        }

        public void Append(int val)
        {
            _vals.Add(val);
            SetPreCalculatedValue(_currval, _ops.Count, val);
            _currval++;
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
            BigInteger asBig = calc.Value;

            var ops = _ops.Skip(calc.OpIndex);
            foreach (var op in ops)
            {
                //var op = _ops[i];
                if (op.OpType == OpType.Add)
                    asBig += op.Val;
                else
                    asBig *= op.Val;
                
            }

            var val = (int) (asBig % MODULO);

            SetPreCalculatedValue(idx, _ops.Count, val);

            return val;
        }



        private PreCalculatedValue GetPreCalculatedValue(int idx)
        { 
            return _calculatedValues[idx];
        }


        private void SetPreCalculatedValue(int idx, int opIndex, int value)
        {
            if (!_calculatedValues.ContainsKey(idx))
                _calculatedValues[idx] = new PreCalculatedValue();
            
            _calculatedValues[idx].OpIndex = opIndex;
            _calculatedValues[idx].Value = value;

        }
    }
}
