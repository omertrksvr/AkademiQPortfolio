ALTER TABLE ProjectsTable
ADD CONSTRAINT FK_ProjectsTable_CategoriesTable
FOREIGN KEY (CategoryId) REFERENCES CategoriesTable(CategoryId);