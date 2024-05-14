namespace Prime.Services
{
    public class PrimeService
    {
        public string GetVectorsTypes(double x1, double y1, double x2, double y2)
        {
            if ((x1 == 0 && y1 == 0) || (x2 == 0 && y2 == 0)) return "Один (або обидва) з векторів - точка";
            string answer = "Вектори";
            bool isColinear;
            bool isOpposite = false;
            double size1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double size2 = Math.Sqrt(x2 * x2 + y2 * y2);
            bool isEqSize = size1 == size2;
            double n = 0;
            if (x1 != 0 && y1 != 0 && x2 != 0 && y2 != 0)
            {
                n = x1 / x2;
                if (y1 / y2 == n) isColinear = true;
                else isColinear = false;
            }
            else if ((y1 == 0 && y2 == 0)|| (x1 == 0 && x2 == 0))
            {
                isColinear = true;
                if(x1==0) n = x1 / x2;
                else n = y1 / y2;
            }
            else isColinear = false;
            if (n < 0) isOpposite = true;
            if (isEqSize) answer += " рівні";
            if (isColinear)
            {
                answer += " колінеарні";
                if (isOpposite) answer += " протилежнопрямлені";
                else answer += " співнапрямлені";
            }
            else answer += " неколінеарні";
            return answer;
        }

    }
}