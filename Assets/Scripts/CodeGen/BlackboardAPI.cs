/**
* Code generation. Don't modify! 
 */
using System.Runtime.CompilerServices;
using Atomic.AI;
using Sample;
using Game.Engine;
using Atomic.Objects;
namespace Atomic.AI
{
    public static class BlackboardAPI
    {
        public const int Character = 1; // Character : class
        public const int ResourceService = 2; // ResourceService : class
        public const int TargetResource = 3; // IAtomicObject : class
        public const int Target = 4; // IAtomicObject : class
        public const int StoppingDistance = 5; // float
        public const int Barn = 6; // Barn : class
        public const int FullBarnText = 7; // GameObject
        public const int NoResourceText = 8; // GameObject
        public const int ResourceStoppingDistance = 9; // float


        ///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharacter(this IBlackboard obj) => obj.HasObject(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Character  GetCharacter(this IBlackboard obj) => obj.GetObject<Character >(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCharacter(this IBlackboard obj, out Character  value) => obj.TryGetObject(Character, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCharacter(this IBlackboard obj, Character  value) => obj.SetObject(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharacter(this IBlackboard obj) => obj.DelObject(Character);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasResourceService(this IBlackboard obj) => obj.HasObject(ResourceService);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ResourceService  GetResourceService(this IBlackboard obj) => obj.GetObject<ResourceService >(ResourceService);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetResourceService(this IBlackboard obj, out ResourceService  value) => obj.TryGetObject(ResourceService, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetResourceService(this IBlackboard obj, ResourceService  value) => obj.SetObject(ResourceService, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelResourceService(this IBlackboard obj) => obj.DelObject(ResourceService);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTargetResource(this IBlackboard obj) => obj.HasObject(TargetResource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAtomicObject  GetTargetResource(this IBlackboard obj) => obj.GetObject<IAtomicObject >(TargetResource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTargetResource(this IBlackboard obj, out IAtomicObject  value) => obj.TryGetObject(TargetResource, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTargetResource(this IBlackboard obj, IAtomicObject  value) => obj.SetObject(TargetResource, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTargetResource(this IBlackboard obj) => obj.DelObject(TargetResource);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTarget(this IBlackboard obj) => obj.HasObject(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAtomicObject  GetTarget(this IBlackboard obj) => obj.GetObject<IAtomicObject >(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTarget(this IBlackboard obj, out IAtomicObject  value) => obj.TryGetObject(Target, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTarget(this IBlackboard obj, IAtomicObject  value) => obj.SetObject(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTarget(this IBlackboard obj) => obj.DelObject(Target);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasStoppingDistance(this IBlackboard obj) => obj.HasFloat(StoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetStoppingDistance(this IBlackboard obj) => obj.GetFloat(StoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetStoppingDistance(this IBlackboard obj, out float value) => obj.TryGetFloat(StoppingDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetStoppingDistance(this IBlackboard obj, float value) => obj.SetFloat(StoppingDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelStoppingDistance(this IBlackboard obj) => obj.DelFloat(StoppingDistance);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBarn(this IBlackboard obj) => obj.HasObject(Barn);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Barn  GetBarn(this IBlackboard obj) => obj.GetObject<Barn >(Barn);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBarn(this IBlackboard obj, out Barn  value) => obj.TryGetObject(Barn, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBarn(this IBlackboard obj, Barn  value) => obj.SetObject(Barn, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBarn(this IBlackboard obj) => obj.DelObject(Barn);




		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasResourceStoppingDistance(this IBlackboard obj) => obj.HasFloat(ResourceStoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetResourceStoppingDistance(this IBlackboard obj) => obj.GetFloat(ResourceStoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetResourceStoppingDistance(this IBlackboard obj, out float value) => obj.TryGetFloat(ResourceStoppingDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetResourceStoppingDistance(this IBlackboard obj, float value) => obj.SetFloat(ResourceStoppingDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelResourceStoppingDistance(this IBlackboard obj) => obj.DelFloat(ResourceStoppingDistance);

    }
}
