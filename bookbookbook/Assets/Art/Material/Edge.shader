// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Unlit/Edge"
{
   Properties
	{
		_Edge ("Edge", Range(0, 0.5)) = 0.05               // 描边的粗细
		_EdgeColor ("EdgeColor", Color) = (1, 1, 1, 1)    // 描边的颜色
		 _FlowColor ("FlowColor", Color) = (1, 1, 1, 1)    // 流光颜色
        _FlowSpeed ("FlowSpeed", Range(0, 10)) = 3   // 流光移动速度
		_MainTex ("MainTex", 2D) = "white" {}            // 主纹理
	}
	SubShader
	{
	    Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" }   
		Pass
		{
			ZWrite Off    
            Blend SrcAlpha OneMinusSrcAlpha  

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			fixed _Edge;
			fixed4 _EdgeColor;
			fixed4 _FlowColor;  
            float _FlowSpeed;  
			sampler2D _MainTex;

			struct appdata
			{
				float4 vertex : POSITION;
				fixed2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				fixed2 uv : TEXCOORD1;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{	
				fixed x = i.uv.x;
				fixed y = i.uv.y;

				// UV坐标的范围是[0, 1]，设置指定范围的纹理颜色为描边色	 	
				if((x < _Edge) || (abs(1 - x) < _Edge) || (y < _Edge) || (abs(1 - y) < _Edge)) 
				{
					 //点旋转公式：  
                    //假设对图片上任意点(x,y)，绕一个坐标点(rx0,ry0)逆时针旋转a角度后的新的坐标设为(x0,y0)，有公式：  
                    //x0 = (x - rx0) * cos(a) - (y - ry0) * sin(a) + rx0 ;  
                    //y0 = (x - rx0) * sin(a) + (y - ry0) * cos(a) + ry0 ;  
  
                    float a = _Time.y * _FlowSpeed;   
                    float2 rotUV;  
  					// 以图片中心为原点进行选择（UI范围是[0, 1],原点为(0.5, 0.5)）
                    x -= 0.5;  
                    y -= 0.5;  
                    rotUV.x = x * cos(a) - y * sin(a) + 0.5;  
                    rotUV.y = x * sin(a) + y * cos(a) + 0.5;  
                     // 使用rotUV.x或rotUV.y都可以，区别就在于初始时的流光位置不同
                    fixed temp = saturate(rotUV.x - 0.5);//-0.5作用是调整流动颜色的比例,相当于调整插值时的插值系数  
                    return _EdgeColor * (1 - temp) + _FlowColor * temp;  //x相当于lerp差值操作
				}
				else       // 边缘外的颜色为透明色
				{
					//fixed4 color = tex2D(_MainTex, i.uv);
					return fixed4(1, 1, 1, 0);
				}
			}
			ENDCG
		}
	}
}
