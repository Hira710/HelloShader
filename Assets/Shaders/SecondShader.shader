Shader "Dreamo/SecondShader"
{
    Properties
    {
        //_Color ("First Color", Color) = (1,1,1,1)
        _MyR ("Red",Range(0,1)) = 0.5
        _MyG ("Green",Range(0,1)) = 0.5
        _MyB ("Blue",Range(0,1)) = 0.5
    }

    SubShader
    {
        Tags { "RenderType"="Opaque"}
        LOD 200

        CGPROGRAM

        #pragma surface surf Standard

        //fixed4 _Color;
        float _MyR;
        float _MyG;
        float _MyB;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            //o.Albedo = _Color.rgb;
            //o.Alpha = _Color.a;
            float3 myRGB = float3(_MyR,_MyG,_MyB);
            o.Albedo = myRGB;
        }

        ENDCG
    }
    FallBack "Diffuse"
}

