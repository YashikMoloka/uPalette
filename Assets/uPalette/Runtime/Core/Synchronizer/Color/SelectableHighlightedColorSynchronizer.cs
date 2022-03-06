﻿using UnityEngine;
using UnityEngine.UI;

namespace uPalette.Runtime.Core.Synchronizer.Color
{
    [AddComponentMenu("")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Selectable))]
    [ColorSynchronizer(typeof(Selectable), "Transition Highlighted Color")]
    public sealed class SelectableHighlightedColorSynchronizer : ColorSynchronizer<Selectable>
    {
        protected internal override UnityEngine.Color GetValue()
        {
            return _component.colors.highlightedColor;
        }

        protected internal override void SetValue(UnityEngine.Color color)
        {
            var colors = _component.colors;
            colors.highlightedColor = color;
            _component.colors = colors;
        }

        protected override bool EqualsToCurrentValue(UnityEngine.Color value)
        {
            return _component.colors.highlightedColor == value;
        }
    }
}
