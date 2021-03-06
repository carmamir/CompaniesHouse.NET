﻿using System;
using LiberisLabs.CompaniesHouse.Request;

namespace LiberisLabs.CompaniesHouse.UriBuilders
{
    public class SearchUriBuilder : ISearchUriBuilder
    {
        private readonly string _path;

        public SearchUriBuilder(string path)
        {
            _path = path;
        }

        public Uri Build(SearchRequest request)
        {
            var query = $"?q={Uri.EscapeDataString(request.Query)}";

            if (request.ItemsPerPage.HasValue)
            {
                query += "&items_per_page=" + request.ItemsPerPage.Value;
            }

            if (request.StartIndex.HasValue)
            {
                query += "&start_index=" + request.StartIndex.Value;
            }

            var pathAndQuery = _path + query;

            return new Uri(pathAndQuery, UriKind.Relative);
        }
    }
}
