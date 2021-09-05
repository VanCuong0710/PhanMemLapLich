using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapLich
{
    public partial class Form1 : Form
    {
        #region Propertise

        private List<List<Button>> matrix; // KHAI BÁO 1 DANH SÁCH MATRIX

        public List<List<Button>> Matrix   // MATRIX CÓ THUỘC TÍNH SET GET
        {
            get { return matrix; }
            set { matrix = value; }
        }

        #endregion 
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();
        }
        private List<string> dateOfWeek =new List<string>(){ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>(); // TẠO MATRIX MỚI
            Button oldBtn = new Button() { Width =0 , Height = 0, Location = new Point(-Cons.margin, 0) }; // KHAI BÁO TRỤC MỚI
            for (int i = 0; i < Cons.DayofColumn; i++) // CHẠY THEO CỘT
            {
                Matrix.Add(new List<Button>()); // ADD
                for (int j = 0; j < Cons.DayofWeek; j++) // CHẠY THEO HÀNG
                {
                    //                               GIÁ TRỊ MẶC ĐỊNH
                    Button btn = new Button() {Width = Cons.dataButtonWidth, Height=Cons.dataButtonHeight};
                    //                            OLD.X + WIDTH              + MARGIN           0
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width+ Cons.margin, oldBtn.Location.Y);
                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn); // ADD
                    oldBtn = btn;
                    
                }
                //                                                                      - TRỪ 1 ĐOẠN        + CHIỀU CAO ĐỂ CÁCH                                                               
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y+ Cons.dataButtonHeight+10) };
            }
            setDefaultDate();
        }


        int dayofmonth(DateTime date) // TRẢ VỀ NGÀY
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28; 
                default:
                    return 30;
            }    
        }

        void AddNumberIntoMaTrixByDate(DateTime date)
        {
            clearMatrix(); // XÓA TRƯỚC KHI VẼ LÀ XÓA
               // MONDAY CỘT KHÔNG
               DateTime useDate = new DateTime(date.Year, date.Month, 1);
            
            int line = 0;

            for (int i = 1; i <= dayofmonth(useDate); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString()); // LẤY CHỈ SỐ CỦA CỘT
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if(isEqualDate(useDate,DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }
                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
                
            }      
        }

        void clearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = ""; // CLEAR CHỮ
                    btn.BackColor = Color.WhiteSmoke; // CLEAR MÀU
                }
            }
        }
        private void dtpK_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMaTrixByDate((sender as DateTimePicker).Value);
        }
        void setDefaultDate()
        {
            dtpK.Value = DateTime.Now;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dtpK.Value = dtpK.Value.AddMonths(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpK.Value = dtpK.Value.AddMonths(+1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setDefaultDate();
        }
        bool isEqualDate(DateTime A,DateTime B)
        {
            return A.Year == B.Year && A.Month == B.Month && A.Day == B.Day;
        }
    }
}
