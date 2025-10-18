using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class SimpleMath
    {
        public delegate void MathMessage(string msg, int result);
        private MathMessage _mmDelegate;

        public delegate void VerifySimpleDelegate();
        private VerifySimpleDelegate _verifSimpDelegate;
        public void SetMathHandler(MathMessage target)
        {
            _mmDelegate = target;
        }
        public void SetVerifSimpDelegateHandler(VerifySimpleDelegate target)
        {
            _verifSimpDelegate = target;
        }
        public void Add(int x, int y)
        {
            _mmDelegate?.Invoke("Adding has completed!", x + y);
        }
        public void Verify(int x, int y)
        {
            _verifSimpDelegate?.Invoke();
        }
    }
}
