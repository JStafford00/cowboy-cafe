﻿using System.Windows;
using System.Windows.Media;

namespace CowboyCafe.Extensions
{
    /*  Author: Jordan Stafford
     *  Class: ExtensionMethod
     *  Purpose:
     */
    public static class ExtensionMethod
    {
        /// <summary>
        /// Find the first ancestor in the Visual Tree that has specified type,
        /// or null if no ancestor is found
        /// </summary>
        /// <typeparam name="T">The type to search for</typeparam>
        /// <param name="obj"></param>
        /// <returns>The first ancestor of type T, or null</returns>
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(obj);

            if (parent == null)
                return null;
            if (parent is T)
                return parent as T;

            return FindAncestor<T>(parent);
        }
    }
}
