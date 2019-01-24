CREATE TABLE IF NOT EXISTS `ItemCarrinho` (
  `Id` int(10) UNSIGNED NOT  NULL AUTO_INCREMENT,
  `product_id` INT NOT NULL,
  `quantidade` INT NOT NULL,
  `carrinho_id` INT NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
