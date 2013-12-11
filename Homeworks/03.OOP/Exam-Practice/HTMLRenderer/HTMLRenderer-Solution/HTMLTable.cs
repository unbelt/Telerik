namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HTMLTable : HTMLElement, ITable
    {
        public const string TableName = "table";
        private const string TableRowOpenTag = "<tr>";
        private const string TableRowCloseTag = "</tr>";
        private const string TableCellOpenTag = "<td>";
        private const string TableCellCloseTag = "</td>";

        private int rows;
        private int cols;
        private IElement[,] cells;

        public HTMLTable(int rows, int cols)
            : base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[this.Rows, this.Cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            set
            {
                if (this.rows < 0)
                {
                    throw new IndexOutOfRangeException("The number of rows must be positive number");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            set
            {
                if (this.cols < 0)
                {
                    throw new IndexOutOfRangeException("The number of cols must be positive number");
                }

                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                this.ValidateRowCol(row, col);

                return this.cells[this.Rows, this.Cols];
            }

            set
            {
                this.ValidateRowCol(row, col);

                this.cells[row, col] = value;
            }
        }

        public override void Render(StringBuilder output)
        {
            for (int row = 0; row < this.Rows; row++)
            {
                output.Append(TableRowOpenTag);

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(TableCellOpenTag);

                    output.Append(this.cells[row, col]);

                    output.Append(TableCellCloseTag);
                }

                output.Append(TableRowCloseTag);
            }
        }

        private void ValidateRowCol(int row, int col)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new IndexOutOfRangeException("The number of rows must be positive number");
            }

            if (col < 0 || col >= this.Cols)
            {
                throw new IndexOutOfRangeException("The number of columns must be positive number");
            }
        }
    }
}