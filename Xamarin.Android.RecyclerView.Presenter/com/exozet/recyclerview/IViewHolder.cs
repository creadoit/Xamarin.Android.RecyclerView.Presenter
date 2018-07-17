﻿namespace com.exozet.recyclerview
{
    public interface IViewHolder
    {
        void OnBindViewHolder();

        void OnViewAttachedToWindow();

        void OnViewDetachedFromWindow();

        void OnViewRecycled();

        void OnFailedToRecycleView();
    }
}
