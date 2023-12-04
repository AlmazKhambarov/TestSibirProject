using System;
namespace TestSibirProject
{

    public class PaginationHelper<T>
    {
        private List<T> data;
        private int itemsPerPage;

        public PaginationHelper(List<T> collection, int itemsPerPage)
        {
            this.data = collection;
            this.itemsPerPage = itemsPerPage;
        }

        public int ItemCount
        {
            get { return data.Count; }
        }

        public int PageCount
        {
            get { return (int)Math.Ceiling((double)data.Count / itemsPerPage); }
        }

        public int ItemsPerPage
        {
            get { return itemsPerPage; }
        }

        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 0 || pageIndex >= PageCount)
            {
                return -1; // Некорректный индекс страницы
            }

            if (pageIndex == PageCount - 1)
            {
                return data.Count % itemsPerPage; // Элементов на последней странице может быть меньше
            }

            return itemsPerPage;
        }

        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= data.Count)
            {
                return -1; // Некорректный индекс элемента
            }

            return itemIndex / itemsPerPage;
        }
    }
}

