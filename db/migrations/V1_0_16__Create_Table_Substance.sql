CREATE TABLE IF NOT EXISTS `substances` (
  `id` int(10) UNSIGNED NOT  NULL AUTO_INCREMENT PRIMARY KEY,
  `name` VARCHAR(255) NOT NULL,
  `name_scie` VARCHAR(255) NOT NULL,
  `descricao` VARCHAR(255)  NOT NULL,
  `composto` VARCHAR(255)  NOT NULL,
  `dt_reg` datetime  NOT NULL,
  `photo` blob  NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
