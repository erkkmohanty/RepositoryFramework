﻿namespace RepositoryFramework
{
	/// <summary>
	/// Pages a result set.
	/// </summary>
	/// <typeparam name="TEntity"></typeparam>
	public interface IPageable<TEntity> where TEntity : class
	{
		/// <summary>
		/// Gets number of items per page (when paging is used)
		/// </summary>
		int PageSize { get; }

		/// <summary>
		/// Gets page number (one based index)
		/// </summary>
		int PageNumber { get; }

		/// <summary>
		/// Use paging
		/// </summary>
		/// <param name="pageNumber">Page to get (one based index).</param>
		/// <param name="pageSize">Number of items per page.</param>
		/// <returns>Current instance</returns>
		IPageable<TEntity> Page(int pageNumber, int pageSize);
	}
}