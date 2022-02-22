using System.Windows.Forms;

namespace Ex02.GUI
{
    public class ColorButton : Button
    {
        private readonly int r_Index;

        public ColorButton(int i_Index)
        {
            r_Index = i_Index;
        }

        public int Index
        {
            get
            {
                return r_Index;
            }
        }
    }
}
