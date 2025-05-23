﻿// <copyright file="ObjMaterial.cs" company="Jérémy Ansel">
// Copyright (c) 2017, 2019 Jérémy Ansel
// </copyright>
// <license>
// Licensed under the MIT license. See LICENSE.txt
// </license>

namespace JeremyAnsel.Media.WavefrontObj
{
    [System.Diagnostics.DebuggerDisplay("Material:{Name}")]
    public class ObjMaterial
    {
        public ObjMaterial()
        {
            this.ReflectionMap = new ObjMaterialReflectionMap();

            this.IlluminationModel = 2;
            this.DissolveFactor = 1.0f;
            this.Sharpness = 60;
            this.OpticalDensity = 1.0f;
        }

        public ObjMaterial(string? name)
            : this()
        {
            this.Name = name;
        }

        public string? Name { get; set; }

        public ObjMaterialColor? AmbientColor { get; set; }

        public ObjMaterialColor? DiffuseColor { get; set; }

        public ObjMaterialColor? EmissiveColor { get; set; }

        public ObjMaterialColor? SpecularColor { get; set; }

        public ObjMaterialColor? TransmissionColor { get; set; }

        public int IlluminationModel { get; set; }

        public float DissolveFactor { get; set; }

        public bool IsHaloDissolve { get; set; }

        public float SpecularExponent { get; set; }

        public int Sharpness { get; set; }

        public float OpticalDensity { get; set; }

        public bool IsAntiAliasingEnabled { get; set; }

        public ObjMaterialMap? AmbientMap { get; set; }

        public ObjMaterialMap? DiffuseMap { get; set; }

        public ObjMaterialMap? EmissiveMap { get; set; }

        public ObjMaterialMap? SpecularMap { get; set; }

        public ObjMaterialMap? SpecularExponentMap { get; set; }

        public ObjMaterialMap? DissolveMap { get; set; }

        public ObjMaterialMap? DecalMap { get; set; }

        public ObjMaterialMap? DispMap { get; set; }

        public ObjMaterialMap? BumpMap { get; set; }

        public ObjMaterialReflectionMap ReflectionMap { get; private set; }

        /// <summary>
        ///     PBR Extension: Pr
        /// </summary>
        public float Roughness { get; set; }

        /// <summary>
        ///     PBR Extension: map_Pr
        /// </summary>
        public ObjMaterialMap? RoughnessMap { get; set; }

        /// <summary>
        ///     PBR Extension: Pm
        /// </summary>
        public float Metallic { get; set; }

        /// <summary>
        ///     PBR Extension: map_Pm
        /// </summary>
        public ObjMaterialMap? MetallicMap { get; set; }

        /// <summary>
        ///     PBR Extension: Ps
        /// </summary>
        public float Sheen { get; set; }

        /// <summary>
        ///     PBR Extension: map_Ps
        /// </summary>
        public ObjMaterialMap? SheenMap { get; set; }

        /// <summary>
        ///     PBR Extension: Pc
        /// </summary>
        public float ClearCoatThickness { get; set; }

        /// <summary>
        ///     PBR Extension: Pcr
        /// </summary>
        public float ClearCoatRoughness { get; set; }

        /// <summary>
        ///     PBR Extension: aniso
        /// </summary>
        public float Anisotropy { get; set; }

        /// <summary>
        ///     PBR Extension: anisor
        /// </summary>
        public float AnisotropyRotation { get; set; }
        
        /// <summary>
        ///     PBR Extension: norm
        /// </summary>
        public ObjMaterialMap? Norm { get; set; }
    }
}