<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the web site, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/documentation/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'ID388094_portfolio' );

/** Database username */
define( 'DB_USER', 'ID388094_portfolio' );

/** Database password */
define( 'DB_PASSWORD', 'Hotmailwar!1' );

/** Database hostname */
define( 'DB_HOST', 'ID388094_portfolio.db.webhosting.be' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         '1b9jkhct|BRvs7V6M?r]xO$jOWSiE!<X0z%n_M8%!<`e~(^eAwuuhl^sRN*lHng7' );
define( 'SECURE_AUTH_KEY',  'R&)wxHB2#06c}|.SWD_L/Qw{Obf-!r7L $r>^LO]38GDlT[VN8yEo(r+F&gkb(>S' );
define( 'LOGGED_IN_KEY',    'k6=gCsv-6<HZ%;~Tj:RWs}P@k%4B8Y3sh{%:H2W#kK68=lT[lV{J=*=R~V6cnatL' );
define( 'NONCE_KEY',        'R[$12b]Csqy?oL?pe;:>E1cV:L8MFwU&?L-xO4N%_9d?[t$FT:fscxeZWp`<$AIr' );
define( 'AUTH_SALT',        '/}{U|?!q^oWAxe!veiim?qK0{6eaM<g^89VvWlmPylH]@*BVrXFqo5QbQf{P0R<t' );
define( 'SECURE_AUTH_SALT', '*@(JXx-p~okn4fc1d4T9IU`!35HuS}^d ]1.VRI=Ve@=C-boig#+Z.gwarz*M#NJ' );
define( 'LOGGED_IN_SALT',   'XY:G%b77-ikIUb597KYVA>)=SP9-~%4Hi1^*]g S9~WQ_(UVS 6}SiOoZ#!#Q@9T' );
define( 'NONCE_SALT',       'woC`5Xo-pHXB#zYS;}n,v41QEv}zjMS/kSdz#|]`;(.8N6I:]z0.v{<c5pm1xiAN' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/documentation/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
