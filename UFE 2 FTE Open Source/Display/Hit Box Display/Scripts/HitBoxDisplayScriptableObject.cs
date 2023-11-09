using UnityEngine;

namespace UFE2FTE
{
    [CreateAssetMenu]
    public class HitBoxDisplayScriptableObject : ScriptableObject
    {
        public string hitBoxDisplayCirclePrefabPath = "Hit Box Display Circle Prefab";
        public GameObject GetHitBoxDisplayCirclePrefab()
        {
            return Resources.Load<GameObject>(hitBoxDisplayCirclePrefabPath);
        }
        public string hitBoxDisplayRectanglePrefabPath = "Hit Box Display Rectangle Prefab";
        public GameObject GetHitBoxDisplayRectanglePrefab()
        {
            return Resources.Load<GameObject>(hitBoxDisplayRectanglePrefabPath);
        }

        public Sprite hitBoxDisplayCircleFilledSprite;
        public Sprite hitBoxDisplayRectangleFilledSprite;

        [Range(0, 100)]
        public int hitBoxDisplayHitBoxesPoolSize = 30;
        [Range(0, 100)]
        public int hitBoxDisplayActiveHurtBoxesPoolSize = 30;
        [Range(0, 100)]
        public int hitBoxDisplayPopcronGizmosLinesAmount = 16;

        [System.Serializable]
        public class CharacterBodyColliderOptions
        {
            public Color32 colliderColor = new Color32(255, 255, 0, 255);
            public int orderInLayerInfront = 10090;
            public int orderInLayerBehind = -10030;
            public bool disableCollider;
        }
        public CharacterBodyColliderOptions characterBodyColliderOptions;

        [System.Serializable]
        public class CharacterHitColliderOptions
        {
            public Color32 colliderColor = new Color32(255, 0, 0, 255);
            public int orderInLayerInfront = 10070;
            public int orderInLayerBehind = -10050;
            public bool disableCollider;
        }
        public CharacterHitColliderOptions characterHitColliderOptions;

        [System.Serializable]
        public class CharacterThrowColliderOptions
        {
            public Color32 colliderColor = new Color32(0, 128, 0, 255);
            public int orderInLayerInfront = 10080;
            public int orderInLayerBehind = -10040;
            public bool disableCollider;
        }
        public CharacterThrowColliderOptions characterThrowColliderOptions;

        [System.Serializable]
        public class CharacterPhysicalInvincibleColliderOptions
        {
            public Color32 colliderColor = new Color32(255, 128, 255, 255);
            public int orderInLayerInfront = 10060;
            public int orderInLayerBehind = -10060;
            public bool disableCollider;
        }
        public CharacterPhysicalInvincibleColliderOptions characterPhysicalInvincibleColliderOptions;

        [System.Serializable]
        public class CharacterProjectileInvincibleColliderOptions
        {
            public Color32 colliderColor = new Color32(128, 0, 128, 255);
            public int orderInLayerInfront = 10050;
            public int orderInLayerBehind = -10070;
            public bool disableCollider;
        }
        public CharacterProjectileInvincibleColliderOptions characterProjectileInvincibleColliderOptions;

        [System.Serializable]
        public class CharacterNoColliderOptions
        {
            public Color32 colliderColor = new Color32(0, 0, 255, 255);
            public int orderInLayerInfront = 10040;
            public int orderInLayerBehind = -10080;
            public bool disableCollider;
        }
        public CharacterNoColliderOptions characterNoColliderOptions;

        [System.Serializable]
        public class CharacterActiveHurtBoxColliderOptions
        {
            public Color32 colliderColor = new Color32(255, 0, 0, 255);
            public int orderInLayerInfront = 10100;
            public int orderInLayerBehind = -10000;
            public bool disableCollider;
            public bool disableCharacterCollidersEqualToCharacterActiveHurtBoxColliders = true;
            public bool disableCharacterBlockableAreaCollidersEqualToCharacterActiveHurtBoxCollider = true;
        }
        public CharacterActiveHurtBoxColliderOptions characterActiveHurtBoxColliderOptions;

        [System.Serializable]
        public class CharacterBlockableAreaColliderOptions
        {
            public Color32 colliderColor = new Color32(255, 255, 255, 255);
            public int orderInLayerInfront = 10030;
            public int orderInLayerBehind = -10090;
            public bool disableCollider;
            public bool disableCharacterCollidersEqualToCharacterBlockableAreaCollider = true;
            public bool disableCharacterActiveHurtBoxCollidersEqualToCharacterBlockableAreaCollider;
        }
        public CharacterBlockableAreaColliderOptions characterBlockableAreaColliderOptions;

        [System.Serializable]
        public class ProjectileHitAreaColliderOptions
        {
            public Color32 colliderColor = new Color32(255, 0, 0, 255);
            public int orderInLayerInfront = 10100;
            public int orderInLayerBehind = -10000;
            public bool disableCollider;
        }
        public ProjectileHitAreaColliderOptions projectileHitAreaColliderOptions;

        [System.Serializable]
        public class ProjectileOnlyColliderOptions
        {
            public Color32 colliderColor = new Color32(255, 128, 0, 255);
            public int orderInLayerInfront = 10099;
            public int orderInLayerBehind = -10001;
            public bool disableCollider;
        }
        public ProjectileOnlyColliderOptions projectileOnlyColliderOptions;

        [System.Serializable]
        public class ProjectileBlockableAreaColliderOptions
        {
            public Color32 colliderColor = new Color32(255, 255, 255, 255);
            public int orderInLayerInfront = 10030;
            public int orderInLayerBehind = -10090;
            public bool disableCollider;
        }
        public ProjectileBlockableAreaColliderOptions projectileBlockableAreaColliderOptions;

        [System.Serializable]
        public class ProjectileTotalHitsTextOptions
        {
            public int orderInLayer = 10110;
        }
        public ProjectileTotalHitsTextOptions projectileTotalHitsTextOptions;

        public void SetAllColliderColorAlphaValue(byte alphaValue)
        {
            characterBodyColliderOptions.colliderColor.a = alphaValue;
            characterHitColliderOptions.colliderColor.a = alphaValue;
            characterThrowColliderOptions.colliderColor.a = alphaValue;
            characterPhysicalInvincibleColliderOptions.colliderColor.a = alphaValue;
            characterProjectileInvincibleColliderOptions.colliderColor.a = alphaValue;
            characterNoColliderOptions.colliderColor.a = alphaValue;
            characterActiveHurtBoxColliderOptions.colliderColor.a = alphaValue;
            characterBlockableAreaColliderOptions.colliderColor.a = alphaValue;

            projectileHitAreaColliderOptions.colliderColor.a = alphaValue;
            projectileOnlyColliderOptions.colliderColor.a = alphaValue;
            projectileBlockableAreaColliderOptions.colliderColor.a = alphaValue;
        }

        public UFE2FTE.HitBoxDisplayMode GetNextEnum(UFE2FTE.HitBoxDisplayMode value)
        {
            int index = (int)value;
            index++;
            if (System.Enum.IsDefined(typeof(UFE2FTE.HitBoxDisplayMode), (UFE2FTE.HitBoxDisplayMode)index) == false)
            {
                index = 0;
            }
            return (UFE2FTE.HitBoxDisplayMode)index;
        }

        public UFE2FTE.HitBoxDisplayMode GetPreviousEnum(UFE2FTE.HitBoxDisplayMode value)
        {
            int index = (int)value;
            index--;
            if (System.Enum.IsDefined(typeof(UFE2FTE.HitBoxDisplayMode), (UFE2FTE.HitBoxDisplayMode)index) == false)
            {
                index = System.Enum.GetValues(typeof(UFE2FTE.HitBoxDisplayMode)).Length - 1;
            }
            return (UFE2FTE.HitBoxDisplayMode)index;
        }

        public string GetStringFromEnum(UFE2FTE.HitBoxDisplayMode hitBoxDisplayMode)
        {
            switch (hitBoxDisplayMode)
            {
                case UFE2FTE.HitBoxDisplayMode.Off:
                    return UFE2FTE.GetStringFromBool(false);

                case UFE2FTE.HitBoxDisplayMode.SpriteRenderer2DInfront:
                    return UFE2FTE.languageOptions.selectedLanguage.HitBoxDisplaySpriteRenderer2DInfront;

                case UFE2FTE.HitBoxDisplayMode.SpriteRenderer2DBehind:
                    return UFE2FTE.languageOptions.selectedLanguage.HitBoxDisplaySpriteRenderer2DBehind;

                case UFE2FTE.HitBoxDisplayMode.MeshRenderer3D:
                    return UFE2FTE.languageOptions.selectedLanguage.HitBoxDisplayMeshRenderer3D;

                case UFE2FTE.HitBoxDisplayMode.PopcronGizmos2D:
                    return UFE2FTE.languageOptions.selectedLanguage.HitBoxDisplayPopcronGizmos2D;

                case UFE2FTE.HitBoxDisplayMode.PopcronGizmos3D:
                    return UFE2FTE.languageOptions.selectedLanguage.HitBoxDisplayPopcronGizmos3D;

                default:
                    return "";
            }
        }
    }
}