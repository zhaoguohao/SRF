﻿#if ENABLE_4_6_FEATURES

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace SRF.UI
{

	[RequireComponent(typeof(CanvasScaler))]
	public class SRRetinaScaler : SRMonoBehaviour
	{

		[SerializeField]
		private int _thresholdDpi = 250;

		[SerializeField]
		private float _retinaScale = 0.5f;

		/// <summary>
		/// Dpi over which to apply scaling
		/// </summary>
		public int ThresholdDpi { get { return _thresholdDpi; } }

		public float RetinaScale { get { return _retinaScale; } }

		private void Start()
		{

			var dpi = Screen.dpi;

			if (dpi <= 0)
				return;

			if (dpi > ThresholdDpi) {

				var scaler = GetComponent<CanvasScaler>();

				scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
				scaler.scaleFactor = RetinaScale;

			}

		}

	}

}

#endif