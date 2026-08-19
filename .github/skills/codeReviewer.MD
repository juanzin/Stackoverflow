---
name: dotnet-code-review
description: Comprehensive workflow for auditing C# code quality, EF Core queries, async practices, and memory performance in .NET solutions.
---

When reviewing C# files or PR diffs:

1. **Static Analysis & Standards**:
   - Compare code changes against guidelines in `review-checklist.md`.
   - Ensure proper dependency injection lifetimes (Transient vs. Scoped vs. Singleton).

2. **Performance & Memory Check**:
   - Check for hidden allocations in tight loops.
   - Verify Entity Framework Core queries avoid N+1 query problems and unindexed filters.

3. **Error Handling & Logging**:
   - Verify `ILogger<T>` is used with structured logging formats (`LoggerMessage` or template strings, not string interpolation).
   - Ensure exceptions are caught selectively and rethrown correctly using `throw;` instead of `throw ex;`.

4. **Output Structure**:
   - Organize findings into three sections: **Critical Issues**, **Performance & Architecture**, and **Suggested Refactorings**.