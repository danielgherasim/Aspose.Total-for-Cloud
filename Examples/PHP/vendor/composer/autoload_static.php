<?php

// autoload_static.php @generated by Composer

namespace Composer\Autoload;

class ComposerStaticInitc3f41290803ae94c22d2eef6218ca7b4
{
    public static $prefixesPsr0 = array (
        'A' => 
        array (
            'Aspose' => 
            array (
                0 => __DIR__ . '/..' . '/aspose/storage-sdk-php/src',
            ),
        ),
    );

    public static function getInitializer(ClassLoader $loader)
    {
        return \Closure::bind(function () use ($loader) {
            $loader->prefixesPsr0 = ComposerStaticInitc3f41290803ae94c22d2eef6218ca7b4::$prefixesPsr0;

        }, null, ClassLoader::class);
    }
}
