using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Dommel
{
    public static partial class DommelMapper
    {
        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static TReturn Get<T1, T2, TReturn>(this IDbConnection connection, object id, Func<T1, T2, TReturn> map) where TReturn : class
        {
            return MultiMap<T1, T2, DontMap, DontMap, DontMap, DontMap, DontMap, TReturn>(connection, map, id).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static async Task<TReturn> GetAsync<T1, T2, TReturn>(this IDbConnection connection, object id, Func<T1, T2, TReturn> map) where TReturn : class
        {
            return (await MultiMapAsync<T1, T2, DontMap, DontMap, DontMap, DontMap, DontMap, TReturn>(connection, map, id)).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static TReturn Get<T1, T2, T3, TReturn>(this IDbConnection connection,
                                                       object id,
                                                       Func<T1, T2, T3, TReturn> map) where TReturn : class
        {
            return MultiMap<T1, T2, T3, DontMap, DontMap, DontMap, DontMap, TReturn>(connection, map, id).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static async Task<TReturn> GetAsync<T1, T2, T3, TReturn>(this IDbConnection connection,
                                                                        object id,
                                                                        Func<T1, T2, T3, TReturn> map) where TReturn : class
        {
            return (await MultiMapAsync<T1, T2, T3, DontMap, DontMap, DontMap, DontMap, TReturn>(connection, map, id)).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static TReturn Get<T1, T2, T3, T4, TReturn>(this IDbConnection connection,
                                                           object id,
                                                           Func<T1, T2, T3, T4, TReturn> map) where TReturn : class
        {
            return MultiMap<T1, T2, T3, T4, DontMap, DontMap, DontMap, TReturn>(connection, map, id).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static async Task<TReturn> GetAsync<T1, T2, T3, T4, TReturn>(this IDbConnection connection,
                                                                            object id,
                                                                            Func<T1, T2, T3, T4, TReturn> map) where TReturn : class
        {
            return (await MultiMapAsync<T1, T2, T3, T4, DontMap, DontMap, DontMap, TReturn>(connection, map, id)).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static TReturn Get<T1, T2, T3, T4, T5, TReturn>(this IDbConnection connection,
                                                               object id,
                                                               Func<T1, T2, T3, T4, T5, TReturn> map) where TReturn : class
        {
            return MultiMap<T1, T2, T3, T4, T5, DontMap, DontMap, TReturn>(connection, map, id).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static async Task<TReturn> GetAsync<T1, T2, T3, T4, T5, TReturn>(this IDbConnection connection,
                                                                                object id,
                                                                                Func<T1, T2, T3, T4, T5, TReturn> map) where TReturn : class
        {
            return (await MultiMapAsync<T1, T2, T3, T4, T5, DontMap, DontMap, TReturn>(connection, map, id)).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="T6">The sixth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static TReturn Get<T1, T2, T3, T4, T5, T6, TReturn>(this IDbConnection connection,
                                                                   object id,
                                                                   Func<T1, T2, T3, T4, T5, T6, TReturn> map) where TReturn : class
        {
            return MultiMap<T1, T2, T3, T4, T5, T6, DontMap, TReturn>(connection, map, id).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="T6">The sixth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static async Task<TReturn> GetAsync<T1, T2, T3, T4, T5, T6, TReturn>(this IDbConnection connection,
                                                                                    object id,
                                                                                    Func<T1, T2, T3, T4, T5, T6, TReturn> map) where TReturn : class
        {
            return (await MultiMapAsync<T1, T2, T3, T4, T5, T6, DontMap, TReturn>(connection, map, id)).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="T6">The sixth type parameter.</typeparam>
        /// <typeparam name="T7">The seventh type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static TReturn Get<T1, T2, T3, T4, T5, T6, T7, TReturn>(this IDbConnection connection,
                                                                       object id,
                                                                       Func<T1, T2, T3, T4, T5, T6, T7, TReturn> map) where TReturn : class
        {
            return MultiMap<T1, T2, T3, T4, T5, T6, T7, TReturn>(connection, map, id).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves the entity of type <typeparamref name="TReturn"/> with the specified id
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="T6">The sixth type parameter.</typeparam>
        /// <typeparam name="T7">The seventh type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="id">The id of the entity in the database.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <returns>The entity with the corresponding id joined with the specified types.</returns>
        public static async Task<TReturn> GetAsync<T1, T2, T3, T4, T5, T6, T7, TReturn>(this IDbConnection connection,
                                                                                        object id,
                                                                                        Func<T1, T2, T3, T4, T5, T6, T7, TReturn> map) where TReturn : class
        {
            return (await MultiMapAsync<T1, T2, T3, T4, T5, T6, T7, TReturn>(connection, map, id)).FirstOrDefault();
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static IEnumerable<TReturn> GetAll<T1, T2, TReturn>(this IDbConnection connection, Func<T1, T2, TReturn> map, bool buffered = true)
        {
            return MultiMap<T1, T2, DontMap, DontMap, DontMap, DontMap, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static Task<IEnumerable<TReturn>> GetAllAsync<T1, T2, TReturn>(this IDbConnection connection, Func<T1, T2, TReturn> map, bool buffered = true)
        {
            return MultiMapAsync<T1, T2, DontMap, DontMap, DontMap, DontMap, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static IEnumerable<TReturn> GetAll<T1, T2, T3, TReturn>(this IDbConnection connection, Func<T1, T2, T3, TReturn> map, bool buffered = true)
        {
            return MultiMap<T1, T2, T3, DontMap, DontMap, DontMap, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static Task<IEnumerable<TReturn>> GetAllAsync<T1, T2, T3, TReturn>(this IDbConnection connection, Func<T1, T2, T3, TReturn> map, bool buffered = true)
        {
            return MultiMapAsync<T1, T2, T3, DontMap, DontMap, DontMap, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static IEnumerable<TReturn> GetAll<T1, T2, T3, T4, TReturn>(this IDbConnection connection, Func<T1, T2, T3, T4, TReturn> map, bool buffered = true)
        {
            return MultiMap<T1, T2, T3, T4, DontMap, DontMap, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static Task<IEnumerable<TReturn>> GetAllAsync<T1, T2, T3, T4, TReturn>(this IDbConnection connection, Func<T1, T2, T3, T4, TReturn> map, bool buffered = true)
        {
            return MultiMapAsync<T1, T2, T3, T4, DontMap, DontMap, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static IEnumerable<TReturn> GetAll<T1, T2, T3, T4, T5, TReturn>(this IDbConnection connection, Func<T1, T2, T3, T4, T5, TReturn> map, bool buffered = true)
        {
            return MultiMap<T1, T2, T3, T4, T5, DontMap, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static Task<IEnumerable<TReturn>> GetAllAsync<T1, T2, T3, T4, T5, TReturn>(this IDbConnection connection, Func<T1, T2, T3, T4, T5, TReturn> map, bool buffered = true)
        {
            return MultiMapAsync<T1, T2, T3, T4, T5, DontMap, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="T6">The sixth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static IEnumerable<TReturn> GetAll<T1, T2, T3, T4, T5, T6, TReturn>(this IDbConnection connection, Func<T1, T2, T3, T4, T5, T6, TReturn> map, bool buffered = true)
        {
            return MultiMap<T1, T2, T3, T4, T5, T6, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="T6">The sixth type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static Task<IEnumerable<TReturn>> GetAllAsync<T1, T2, T3, T4, T5, T6, TReturn>(this IDbConnection connection, Func<T1, T2, T3, T4, T5, T6, TReturn> map, bool buffered = true)
        {
            return MultiMapAsync<T1, T2, T3, T4, T5, T6, DontMap, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="T6">The sixth type parameter.</typeparam>
        /// <typeparam name="T7">The seventh type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static IEnumerable<TReturn> GetAll<T1, T2, T3, T4, T5, T6, T7, TReturn>(this IDbConnection connection, Func<T1, T2, T3, T4, T5, T6, T7, TReturn> map, bool buffered = true)
        {
            return MultiMap<T1, T2, T3, T4, T5, T6, T7, TReturn>(connection, map, buffered: buffered);
        }

        /// <summary>
        /// Retrieves all the entities of type <typeparamref name="TReturn"/>
        /// joined with the types specified as type parameters.
        /// </summary>
        /// <typeparam name="T1">The first type parameter. This is the source entity.</typeparam>
        /// <typeparam name="T2">The second type parameter.</typeparam>
        /// <typeparam name="T3">The third type parameter.</typeparam>
        /// <typeparam name="T4">The fourth type parameter.</typeparam>
        /// <typeparam name="T5">The fifth type parameter.</typeparam>
        /// <typeparam name="T6">The sixth type parameter.</typeparam>
        /// <typeparam name="T7">The seventh type parameter.</typeparam>
        /// <typeparam name="TReturn">The return type parameter.</typeparam>
        /// <param name="connection">The connection to the database. This can either be open or closed.</param>
        /// <param name="map">The mapping to perform on the entities in the result set.</param>
        /// <param name="buffered">
        /// A value indicating whether the result of the query should be executed directly,
        /// or when the query is materialized (using <c>ToList()</c> for example).
        /// </param>
        /// <returns>
        /// A collection of entities of type <typeparamref name="TReturn"/>
        /// joined with the specified type types.
        /// </returns>
        public static Task<IEnumerable<TReturn>> GetAllAsync<T1, T2, T3, T4, T5, T6, T7, TReturn>(this IDbConnection connection, Func<T1, T2, T3, T4, T5, T6, T7, TReturn> map, bool buffered = true)
        {
            return MultiMapAsync<T1, T2, T3, T4, T5, T6, T7, TReturn>(connection, map, buffered: buffered);
        }

        private static IEnumerable<TReturn> MultiMap<T1, T2, T3, T4, T5, T6, T7, TReturn>(IDbConnection connection, Delegate map, object id = null, bool buffered = true)
        {
            var resultType = typeof(TReturn);
            var
                includeTypes = new[]
                               {
                                   typeof(T1),
                                   typeof(T2),
                                   typeof(T3),
                                   typeof(T4),
                                   typeof(T5),
                                   typeof(T6),
                                   typeof(T7)
                               }
                    .Where(t => t != typeof(DontMap))
                    .ToArray();

            var sql = BuildMultiMapQuery(resultType, includeTypes, id, out var parameters);
            LogQuery<TReturn>(sql);

            switch (includeTypes.Length)
            {
                case 2:
                    return connection.Query(sql, (Func<T1, T2, TReturn>)map, parameters, buffered: buffered);
                case 3:
                    return connection.Query(sql, (Func<T1, T2, T3, TReturn>)map, parameters, buffered: buffered);
                case 4:
                    return connection.Query(sql, (Func<T1, T2, T3, T4, TReturn>)map, parameters, buffered: buffered);
                case 5:
                    return connection.Query(sql, (Func<T1, T2, T3, T4, T5, TReturn>)map, parameters, buffered: buffered);
                case 6:
                    return connection.Query(sql, (Func<T1, T2, T3, T4, T5, T6, TReturn>)map, parameters, buffered: buffered);
                case 7:
                    return connection.Query(sql, (Func<T1, T2, T3, T4, T5, T6, T7, TReturn>)map, parameters, buffered: buffered);
            }

            throw new InvalidOperationException($"Invalid amount of include types: {includeTypes.Length}.");
        }

        private static Task<IEnumerable<TReturn>> MultiMapAsync<T1, T2, T3, T4, T5, T6, T7, TReturn>(IDbConnection connection, Delegate map, object id = null, bool buffered = true)
        {
            var resultType = typeof(TReturn);
            var
                includeTypes = new[]
                               {
                                   typeof(T1),
                                   typeof(T2),
                                   typeof(T3),
                                   typeof(T4),
                                   typeof(T5),
                                   typeof(T6),
                                   typeof(T7)
                               }
                    .Where(t => t != typeof(DontMap))
                    .ToArray();

            var sql = BuildMultiMapQuery(resultType, includeTypes, id, out var parameters);
            LogQuery<TReturn>(sql);

            switch (includeTypes.Length)
            {
                case 2:
                    return connection.QueryAsync(sql, (Func<T1, T2, TReturn>)map, parameters, buffered: buffered);
                case 3:
                    return connection.QueryAsync(sql, (Func<T1, T2, T3, TReturn>)map, parameters, buffered: buffered);
                case 4:
                    return connection.QueryAsync(sql, (Func<T1, T2, T3, T4, TReturn>)map, parameters, buffered: buffered);
                case 5:
                    return connection.QueryAsync(sql, (Func<T1, T2, T3, T4, T5, TReturn>)map, parameters, buffered: buffered);
                case 6:
                    return connection.QueryAsync(sql, (Func<T1, T2, T3, T4, T5, T6, TReturn>)map, parameters, buffered: buffered);
                case 7:
                    return connection.QueryAsync(sql, (Func<T1, T2, T3, T4, T5, T6, T7, TReturn>)map, parameters, buffered: buffered);
            }

            throw new InvalidOperationException($"Invalid amount of include types: {includeTypes.Length}.");
        }

        private static string BuildMultiMapQuery(Type resultType, Type[] includeTypes, object id, out DynamicParameters parameters)
        {
            var resultTableName = Resolvers.Table(resultType);
            var resultTableKeyColumnName = Resolvers.Column(Resolvers.KeyProperty(resultType));

            var sql = $"select * from {resultTableName}";

            for (var i = 1; i < includeTypes.Length; i++)
            {
                // Determine the table to join with.
                var sourceType = includeTypes[i - 1];
                var sourceTableName = Resolvers.Table(sourceType);

                // Determine the table name of the joined table.
                var includeType = includeTypes[i];
                var foreignKeyTableName = Resolvers.Table(includeType);

                // Determine the foreign key and the relationship type.
                var foreignKeyProperty = Resolvers.ForeignKeyProperty(sourceType, includeType, out var relation);
                var foreignKeyPropertyName = Resolvers.Column(foreignKeyProperty);

                // If the foreign key property is nullable, use a left-join.
                var joinType = Nullable.GetUnderlyingType(foreignKeyProperty.PropertyType) != null
                                   ? "left"
                                   : "inner";

                switch (relation)
                {
                    case ForeignKeyRelation.OneToOne:
                        // Determine the primary key of the foreign key table.
                        var foreignKeyTableKeyColumName = Resolvers.Column(Resolvers.KeyProperty(includeType));

                        sql += string.Format(" {0} join {1} on {2}.{3} = {1}.{4}",
                                             joinType,
                                             foreignKeyTableName,
                                             sourceTableName,
                                             foreignKeyPropertyName,
                                             foreignKeyTableKeyColumName);
                        break;

                    case ForeignKeyRelation.OneToMany:
                        // Determine the primary key of the source table.
                        var sourceKeyColumnName = Resolvers.Column(Resolvers.KeyProperty(sourceType));

                        sql += string.Format(" {0} join {1} on {2}.{3} = {1}.{4}",
                                             joinType,
                                             foreignKeyTableName,
                                             sourceTableName,
                                             sourceKeyColumnName,
                                             foreignKeyPropertyName);
                        break;

                    case ForeignKeyRelation.ManyToMany:
                        throw new NotImplementedException("Many-to-many relationships are not supported yet.");

                    default:
                        throw new NotImplementedException($"Foreign key relation type '{relation}' is not implemented.");
                }
            }

            parameters = null;
            if (id != null)
            {
                sql += $" where {resultTableName}.{resultTableKeyColumnName} = @Id";

                parameters = new DynamicParameters();
                parameters.Add("Id", id);
            }

            return sql;
        }

        private class DontMap
        {
        }
    }
}
