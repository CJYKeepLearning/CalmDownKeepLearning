alter table USER alter column ID BIGINT auto_increment;
alter table QUESTION alter column ID BIGINT auto_increment;
alter table QUESTION alter column CREATOR BIGINT;
alter table COMMENT alter column COMMENTATOR BIGINT;