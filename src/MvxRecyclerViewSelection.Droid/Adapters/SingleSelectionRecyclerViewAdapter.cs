using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using MvvmCross.Platforms.Android.Binding.BindingContext;

namespace MvxRecyclerViewSelection.Droid.Adapters
{
    public class SingleSelectionRecyclerViewAdapter : MvvmCross.Droid.Support.V7.RecyclerView.MvxRecyclerAdapter
    {
        public SingleSelectionRecyclerViewAdapter(IMvxAndroidBindingContext bindingContext) : base(bindingContext)
        {
        }

        public SingleSelectionRecyclerViewAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            base.OnBindViewHolder(holder, position);
            holder.ItemView.Selected = _selectedPosition == position;
            holder.ItemView.Click += (s, e) => SelectIndex(holder.AdapterPosition);
        }

        private void SelectIndex(int index)
        {
            NotifyItemChanged(_selectedPosition);
            _selectedPosition = index;
            NotifyItemChanged(_selectedPosition);
        }

        private int _selectedPosition = RecyclerView.NoPosition;
    }
}
