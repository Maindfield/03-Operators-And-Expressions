using System;

namespace BitsExchangeAdvanced
{
    class BitsExchangeAdvanced
    {
        static void Main()
        {
            int q;
            int k;
            int Mask;
            int pMask = 0;
            uint maskP;
            int qMask = 0;
            uint maskQ;
            Console.Write("Enter uint number: ");
            uint num = uint.Parse(Console.ReadLine());
            Console.Write("Enter the p positione of the minor bit, for exchange: ");
            int p = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter the q positione of the elder bit, for exchange(32>q>{0} !!!): ", p);
                q = int.Parse(Console.ReadLine());
            } while (q >= 32 || q <= p);
            do
            {
                Console.Write("Enter {1}>k <={0}, which is the offset.\nOffset is the number of bits chosen to exchange!", (q - p) - 1, 32 - q);
                k = int.Parse(Console.ReadLine());
            } while (k > (q - p) || k > (32 - q));
            int offset = (q - p);
            if (k == 0)
            {
                Mask = 1 << p;
                pMask = pMask | Mask;
                Mask = 1 << q;
                qMask = qMask | Mask;
            }
            else
            {
                for (int i = p; i < p + k; i++)
                {
                    Mask = 1 << i;
                    pMask = pMask | Mask;
                }
                for (int i = q; i < q + k; i++)
                {
                    Mask = 1 << i;
                    qMask = qMask | Mask;
                }
            }
            maskP = (uint)(pMask & num);
            uint newQ = maskP << offset;
            maskQ = (uint)(qMask & num);
            uint newP = maskQ >> offset;
            qMask = ~qMask;
            pMask = ~pMask;
            int trueMask = pMask & qMask;
            uint midNum = (uint)(num & trueMask);
            uint result = midNum | newP;
            result = result | newQ;
            Console.WriteLine("{0,11}->{1}", num, Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine("{0,11}->{1}", result, Convert.ToString(result, 2).PadLeft(32, '0'));
        }
    }
}
