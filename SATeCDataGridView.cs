using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace SATeC {
    public class SATecDataGridView : DataGridView {

        public override DataGridViewAdvancedBorderStyle AdjustColumnHeaderBorderStyle(
            DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput,
            DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceHolder,
            bool firstDisplayedColumn,
            bool lastVisibleColumn) {
            // Customize the left border of the first column header and the 
            // bottom border of all the column headers. Use the input style for  
            // all other borders.
            dataGridViewAdvancedBorderStylePlaceHolder.Left = dataGridViewAdvancedBorderStyleInput.Left;
            dataGridViewAdvancedBorderStylePlaceHolder.Bottom = DataGridViewAdvancedCellBorderStyle.Outset;

            dataGridViewAdvancedBorderStylePlaceHolder.Right = lastVisibleColumn ? DataGridViewAdvancedCellBorderStyle.None : dataGridViewAdvancedBorderStyleInput.Right;
            dataGridViewAdvancedBorderStylePlaceHolder.Top = dataGridViewAdvancedBorderStyleInput.Top;

            return dataGridViewAdvancedBorderStylePlaceHolder;
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e) {
            if(e.RowIndex == -1) {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                using(Pen customPen = new Pen(Color.White, 1)) {
                    Rectangle rect = e.CellBounds;
                    rect.Width -= 2; 
                    //rect.Height -= 2; 
                    e.Graphics.DrawRectangle(customPen, rect);
                }
                e.Handled = true;
            }
            base.OnCellPainting(e);
        }
    }
}
