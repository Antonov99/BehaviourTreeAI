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

    }
}
